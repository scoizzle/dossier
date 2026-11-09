# Fact b05a8f9c

Store id: 6bd76a36-ba0f-4d1d-b54f-7b8910ba8798

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
- posted_at: `2026-11-09T22:39:42.3727700+00:00`

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
  "id": "6bd76a36-ba0f-4d1d-b54f-7b8910ba8798",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3727700+00:00"
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
  "subject_id": "6e4fa724-7ad2-4b16-a555-2487fe0c72c6",
  "subject_name": "django/db/models/fields/__init__::CharField",
  "tags": [
    "entity:class"
  ],
  "text": "class CharField(Field)"
}
```
