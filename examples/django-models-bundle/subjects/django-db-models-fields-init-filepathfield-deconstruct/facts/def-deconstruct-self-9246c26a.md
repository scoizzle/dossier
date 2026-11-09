# Fact 9246c26a

Store id: 85dc230e-8bcb-4106-9879-ad9d87ad5ffa

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
- posted_at: `2026-11-09T23:44:50.1476100+00:00`

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
  "id": "85dc230e-8bcb-4106-9879-ad9d87ad5ffa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1476100+00:00"
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
  "subject_id": "b17584ea-7ba1-49b9-bfee-f8b66d6f6375",
  "subject_name": "django/db/models/fields/__init__::FilePathField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
