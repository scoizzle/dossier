# Fact 9246c26a

Store id: 974f9f97-0f52-437f-ac70-4665d6b44536

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
- posted_at: `2026-11-09T23:31:56.6767790+00:00`

## Data

```json
{
  "end_line": 2074,
  "entity_kind": "method",
  "parent": "FilePathField",
  "start_line": 2060,
  "symbol": "FilePathField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2060,"selector":"L2060-L2074","symbol":"FilePathField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FilePathField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2074,
    "entity_kind": "method",
    "parent": "FilePathField",
    "start_line": 2060,
    "symbol": "FilePathField.deconstruct"
  },
  "id": "974f9f97-0f52-437f-ac70-4665d6b44536",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6767790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2060,
        "selector": "L2060-L2074",
        "symbol": "FilePathField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b9528a0a-fe83-4c20-bf90-ffd0210e86bd",
  "subject_name": "django/db/models/fields/__init__::FilePathField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
