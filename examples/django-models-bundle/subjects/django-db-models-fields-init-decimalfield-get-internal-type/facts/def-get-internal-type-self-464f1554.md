# Fact 464f1554

Store id: e67eb595-dbab-46e5-b8f0-575bb64ace14

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
- posted_at: `2026-11-09T22:39:42.4591750+00:00`

## Data

```json
{
  "end_line": 1891,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1890,
  "symbol": "DecimalField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1890,"selector":"L1890-L1891","symbol":"DecimalField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1891,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1890,
    "symbol": "DecimalField.get_internal_type"
  },
  "id": "e67eb595-dbab-46e5-b8f0-575bb64ace14",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4591750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1890,
        "selector": "L1890-L1891",
        "symbol": "DecimalField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "2243ae41-78a9-4a05-8682-684d65a83420",
  "subject_name": "django/db/models/fields/__init__::DecimalField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
