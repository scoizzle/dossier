# Fact 9246c26a

Store id: ff4a6845-3246-4037-b836-6968a06b3908

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
- posted_at: `2026-11-09T22:39:42.5114300+00:00`

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
  "id": "ff4a6845-3246-4037-b836-6968a06b3908",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5114300+00:00"
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
  "subject_id": "af245ed1-252c-4b5b-9367-b93d8fae7786",
  "subject_name": "django/db/models/fields/__init__::FilePathField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
