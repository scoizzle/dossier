# Fact 1cc37b19

Store id: 39f540ca-f022-44da-9728-d92d06e7cd5f

## Text

```text
class IntegerField(Field)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.1586490+00:00`

## Data

```json
{
  "end_line": 2238,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2141,
  "symbol": "IntegerField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2141,"selector":"L2141-L2238","symbol":"IntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2238,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2141,
    "symbol": "IntegerField"
  },
  "id": "39f540ca-f022-44da-9728-d92d06e7cd5f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1586490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2141,
        "selector": "L2141-L2238",
        "symbol": "IntegerField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "d691eabb-768f-4a29-b369-c40bcaf03b4c",
  "subject_name": "django/db/models/fields/__init__::IntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class IntegerField(Field)"
}
```
