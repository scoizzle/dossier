# Fact b05a8f9c

Store id: e1d06cf1-e00b-45d6-a83b-cefa6563cb10

## Text

```text
class CharField(Field)
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
- posted_at: `2026-11-09T23:44:50.0576410+00:00`

## Data

```json
{
  "end_line": 1362,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 1246,
  "symbol": "CharField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1246,"selector":"L1246-L1362","symbol":"CharField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1362,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 1246,
    "symbol": "CharField"
  },
  "id": "e1d06cf1-e00b-45d6-a83b-cefa6563cb10",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0576410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1246,
        "selector": "L1246-L1362",
        "symbol": "CharField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "068e01d7-9dc4-422a-abc5-b3f168bfdd91",
  "subject_name": "django/db/models/fields/__init__::CharField",
  "tags": [
    "entity:class"
  ],
  "text": "class CharField(Field)"
}
```
