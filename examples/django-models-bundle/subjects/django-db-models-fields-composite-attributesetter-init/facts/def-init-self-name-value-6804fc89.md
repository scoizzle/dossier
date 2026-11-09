# Fact 6804fc89

Store id: 5957872d-dbf4-479b-bf21-1a730f6afbc3

## Text

```text
def __init__(self, name, value)
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
- posted_at: `2026-11-09T22:39:42.9783140+00:00`

## Data

```json
{
  "end_line": 20,
  "entity_kind": "method",
  "parent": "AttributeSetter",
  "start_line": 19,
  "symbol": "AttributeSetter.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":19,"selector":"L19-L20","symbol":"AttributeSetter.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::AttributeSetter.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 20,
    "entity_kind": "method",
    "parent": "AttributeSetter",
    "start_line": 19,
    "symbol": "AttributeSetter.__init__"
  },
  "id": "5957872d-dbf4-479b-bf21-1a730f6afbc3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.9783140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 19,
        "selector": "L19-L20",
        "symbol": "AttributeSetter.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "a06f942c-3485-4a83-ba1b-1f8a67d37c29",
  "subject_name": "django/db/models/fields/composite::AttributeSetter.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, name, value)"
}
```
