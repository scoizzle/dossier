# Fact 2d39baf5

Store id: 3e10f130-51f1-424c-bb60-96fab2a9e1c3

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
- posted_at: `2026-11-09T22:39:42.4672900+00:00`

## Data

```json
{
  "end_line": 1933,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1925,
  "symbol": "DecimalField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1925,"selector":"L1925-L1933","symbol":"DecimalField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1933,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1925,
    "symbol": "DecimalField.formfield"
  },
  "id": "3e10f130-51f1-424c-bb60-96fab2a9e1c3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4672900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1925,
        "selector": "L1925-L1933",
        "symbol": "DecimalField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "21c4b01d-a34d-4a04-a7ff-c633ffc2071e",
  "subject_name": "django/db/models/fields/__init__::DecimalField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
