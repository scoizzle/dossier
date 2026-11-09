# Fact c771289f

Store id: 9b034222-7f24-4d34-909b-b3cbefdbf083

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T22:39:42.7679700+00:00`

## Data

```json
{
  "end_line": 2981,
  "entity_kind": "method",
  "parent": "SmallAutoField",
  "start_line": 2980,
  "symbol": "SmallAutoField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2980,"selector":"L2980-L2981","symbol":"SmallAutoField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SmallAutoField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2981,
    "entity_kind": "method",
    "parent": "SmallAutoField",
    "start_line": 2980,
    "symbol": "SmallAutoField.get_internal_type"
  },
  "id": "9b034222-7f24-4d34-909b-b3cbefdbf083",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7679700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2980,
        "selector": "L2980-L2981",
        "symbol": "SmallAutoField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "72871cbe-c77a-4f4e-9661-86e604006cf0",
  "subject_name": "django/db/models/fields/__init__::SmallAutoField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
