# Fact 472d9cb5

Store id: 43aef73b-2c77-4fde-81bc-5c8faa5392cf

## Text

```text
def set_attributes_from_name(self, name)
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
- posted_at: `2026-11-09T23:44:50.0278340+00:00`

## Data

```json
{
  "end_line": 982,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 977,
  "symbol": "Field.set_attributes_from_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":977,"selector":"L977-L982","symbol":"Field.set_attributes_from_name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.set_attributes_from_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 982,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 977,
    "symbol": "Field.set_attributes_from_name"
  },
  "id": "43aef73b-2c77-4fde-81bc-5c8faa5392cf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0278340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 977,
        "selector": "L977-L982",
        "symbol": "Field.set_attributes_from_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "2b698513-0b82-4eff-b8f4-28d50c1275fe",
  "subject_name": "django/db/models/fields/__init__::Field.set_attributes_from_name",
  "tags": [
    "entity:method"
  ],
  "text": "def set_attributes_from_name(self, name)"
}
```
