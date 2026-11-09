# Fact 47a15834

Store id: 7e7d0eeb-7507-4154-912c-21427fb8b228

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:44:48.7838020+00:00`

## Data

```json
{
  "end_line": 266,
  "entity_kind": "method",
  "parent": "Deferrable",
  "start_line": 265,
  "symbol": "Deferrable.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":265,"selector":"L265-L266","symbol":"Deferrable.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::Deferrable.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 266,
    "entity_kind": "method",
    "parent": "Deferrable",
    "start_line": 265,
    "symbol": "Deferrable.__repr__"
  },
  "id": "7e7d0eeb-7507-4154-912c-21427fb8b228",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7838020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 265,
        "selector": "L265-L266",
        "symbol": "Deferrable.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "cf359688-bdda-4f49-a662-84b55cec0b1c",
  "subject_name": "django/db/models/constraints::Deferrable.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
