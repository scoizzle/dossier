# Fact 472d9cb5

Store id: cf488257-6d12-46a4-a650-c8741c3b43b3

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
- posted_at: `2026-11-09T23:31:56.4974540+00:00`

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
  "id": "cf488257-6d12-46a4-a650-c8741c3b43b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4974540+00:00"
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
  "subject_id": "35cd6b25-60d7-4ff6-9503-f42ce9bb09fb",
  "subject_name": "django/db/models/fields/__init__::Field.set_attributes_from_name",
  "tags": [
    "entity:method"
  ],
  "text": "def set_attributes_from_name(self, name)"
}
```
