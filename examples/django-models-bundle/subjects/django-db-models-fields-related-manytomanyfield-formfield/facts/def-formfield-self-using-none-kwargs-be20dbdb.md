# Fact be20dbdb

Store id: 2ca87227-51f8-4c80-8a18-50ccff4794d3

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
- posted_at: `2026-11-09T22:39:44.5105800+00:00`

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
  "id": "2ca87227-51f8-4c80-8a18-50ccff4794d3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.5105800+00:00"
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
  "subject_id": "7adb1c4a-0c68-45f6-87f0-356a68ee319e",
  "subject_name": "django/db/models/fields/related::ManyToManyField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, *, using=None, **kwargs)"
}
```
