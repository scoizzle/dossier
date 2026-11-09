# Fact dccd4b77

Store id: 61406ab9-69c4-420c-a67c-3edda44ebe97

## Text

```text
class Right(Left)
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
- posted_at: `2026-11-09T23:44:54.1328060+00:00`

## Data

```json
{
  "end_line": 290,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 282,
  "symbol": "Right"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":282,"selector":"L282-L290","symbol":"Right"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Right](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 290,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 282,
    "symbol": "Right"
  },
  "id": "61406ab9-69c4-420c-a67c-3edda44ebe97",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1328060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 282,
        "selector": "L282-L290",
        "symbol": "Right"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "b0e062e8-94f4-44e7-aa32-b4fe6eb286cc",
  "subject_name": "django/db/models/functions/text::Right",
  "tags": [
    "entity:class"
  ],
  "text": "class Right(Left)"
}
```
