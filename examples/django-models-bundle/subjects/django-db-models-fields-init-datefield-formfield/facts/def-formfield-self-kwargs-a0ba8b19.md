# Fact a0ba8b19

Store id: d3b60f4d-2b9c-49ee-812f-c9d149d4f90d

## Text

```text
def formfield(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:56.5906980+00:00`

## Data

```json
{
  "end_line": 1596,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1590,
  "symbol": "DateField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1590,"selector":"L1590-L1596","symbol":"DateField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1596,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1590,
    "symbol": "DateField.formfield"
  },
  "id": "d3b60f4d-2b9c-49ee-812f-c9d149d4f90d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5906980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1590,
        "selector": "L1590-L1596",
        "symbol": "DateField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "29fbeb3f-9963-4bce-99ea-4b88834bf285",
  "subject_name": "django/db/models/fields/__init__::DateField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
