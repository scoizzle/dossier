# Fact 9be9992a

Store id: 3d6cc739-9472-420c-91da-70b6b58f39ad

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T22:39:42.4940630+00:00`

## Data

```json
{
  "end_line": 2010,
  "entity_kind": "method",
  "parent": "EmailField",
  "start_line": 2006,
  "symbol": "EmailField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2006,"selector":"L2006-L2010","symbol":"EmailField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::EmailField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2010,
    "entity_kind": "method",
    "parent": "EmailField",
    "start_line": 2006,
    "symbol": "EmailField.deconstruct"
  },
  "id": "3d6cc739-9472-420c-91da-70b6b58f39ad",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4940630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2006,
        "selector": "L2006-L2010",
        "symbol": "EmailField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "41491c99-b331-4410-a5b5-d8fd662898cf",
  "subject_name": "django/db/models/fields/__init__::EmailField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
