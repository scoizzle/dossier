# Fact b05a8f9c

Store id: 7e45f9c9-3ff3-4304-a5e0-3f6635b34379

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
- posted_at: `2026-11-09T23:31:56.5444820+00:00`

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
  "id": "7e45f9c9-3ff3-4304-a5e0-3f6635b34379",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5444820+00:00"
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
  "subject_id": "528759d7-69dd-4c50-ab76-6c5f9e088b54",
  "subject_name": "django/db/models/fields/__init__::CharField",
  "tags": [
    "entity:class"
  ],
  "text": "class CharField(Field)"
}
```
