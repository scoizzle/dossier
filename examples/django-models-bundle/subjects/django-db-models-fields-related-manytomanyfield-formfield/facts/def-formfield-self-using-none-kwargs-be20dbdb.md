# Fact be20dbdb

Store id: 5e17ade4-bc24-4c14-95e2-1a977a430818

## Text

```text
def formfield(self, *, using=None, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.6774750+00:00`

## Data

```json
{
  "end_line": 2201,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2188,
  "symbol": "ManyToManyField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2188,"selector":"L2188-L2201","symbol":"ManyToManyField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2201,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2188,
    "symbol": "ManyToManyField.formfield"
  },
  "id": "5e17ade4-bc24-4c14-95e2-1a977a430818",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6774750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2188,
        "selector": "L2188-L2201",
        "symbol": "ManyToManyField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "2b480c66-8113-4acb-b329-ce3398e998db",
  "subject_name": "django/db/models/fields/related::ManyToManyField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, *, using=None, **kwargs)"
}
```
