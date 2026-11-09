# Fact feb2ce14

Store id: f69ada82-78f0-4c4e-86cb-39bd4e5279fa

## Text

```text
class Left(Func)
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
- posted_at: `2026-11-09T23:44:54.0825000+00:00`

## Data

```json
{
  "end_line": 176,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 154,
  "symbol": "Left"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":154,"selector":"L154-L176","symbol":"Left"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Left](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 176,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 154,
    "symbol": "Left"
  },
  "id": "f69ada82-78f0-4c4e-86cb-39bd4e5279fa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0825000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 154,
        "selector": "L154-L176",
        "symbol": "Left"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "57de39f9-8a94-4e60-8021-8b0b45e0f71b",
  "subject_name": "django/db/models/functions/text::Left",
  "tags": [
    "entity:class"
  ],
  "text": "class Left(Func)"
}
```
