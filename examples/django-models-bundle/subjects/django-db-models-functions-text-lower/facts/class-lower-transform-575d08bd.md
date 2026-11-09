# Fact 575d08bd

Store id: 6d1494b4-33d1-4312-a9d2-cd6c71c734c3

## Text

```text
class Lower(Transform)
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
- posted_at: `2026-11-09T22:39:47.1201050+00:00`

## Data

```json
{
  "end_line": 194,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 192,
  "symbol": "Lower"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":192,"selector":"L192-L194","symbol":"Lower"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Lower](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 194,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 192,
    "symbol": "Lower"
  },
  "id": "6d1494b4-33d1-4312-a9d2-cd6c71c734c3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1201050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 192,
        "selector": "L192-L194",
        "symbol": "Lower"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "ca1de28d-d6be-4c27-bab4-12d6ae9e3d84",
  "subject_name": "django/db/models/functions/text::Lower",
  "tags": [
    "entity:class"
  ],
  "text": "class Lower(Transform)"
}
```
