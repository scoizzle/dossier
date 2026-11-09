# Fact e2791f66

Store id: 847d9e42-051f-461c-a7a5-c3b3cfe8d140

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
- posted_at: `2026-11-09T22:39:42.5411760+00:00`

## Data

```json
{
  "end_line": 2218,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2217,
  "symbol": "IntegerField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2217,"selector":"L2217-L2218","symbol":"IntegerField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2218,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2217,
    "symbol": "IntegerField.get_internal_type"
  },
  "id": "847d9e42-051f-461c-a7a5-c3b3cfe8d140",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5411760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2217,
        "selector": "L2217-L2218",
        "symbol": "IntegerField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5899d87e-15df-4f3b-a5f7-91ab9bcd3485",
  "subject_name": "django/db/models/fields/__init__::IntegerField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
