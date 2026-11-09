# Fact fe8b901b

Store id: 66eb43d8-f95e-42ea-b74e-363ddbd66163

## Text

```text
def validators(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.4664580+00:00`

## Data

```json
{
  "end_line": 820,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 814,
  "symbol": "Field.validators"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":814,"selector":"L814-L820","symbol":"Field.validators"}`

## Items

```json
[
  {
    "text": "Some validators can't be created at field initialization time. This method provides a way to delay their creation until required.",
    "locator": {
      "line": 816
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.validators](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 820,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 814,
    "symbol": "Field.validators"
  },
  "id": "66eb43d8-f95e-42ea-b74e-363ddbd66163",
  "items": [
    {
      "locator": {
        "line": 816
      },
      "text": "Some validators can't be created at field initialization time. This method provides a way to delay their creation until required."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4664580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 814,
        "selector": "L814-L820",
        "symbol": "Field.validators"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "64eb587c-7822-4903-8745-edfee9eecfac",
  "subject_name": "django/db/models/fields/__init__::Field.validators",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def validators(self)"
}
```
