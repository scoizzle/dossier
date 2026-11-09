# Fact 575d08bd

Store id: 826663c0-21a0-45b1-af50-2f116b4d7479

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
- posted_at: `2026-11-09T23:32:02.2056250+00:00`

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
  "id": "826663c0-21a0-45b1-af50-2f116b4d7479",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2056250+00:00"
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
  "subject_id": "d035abb6-8d5a-4baf-b6b3-28348c7daf83",
  "subject_name": "django/db/models/functions/text::Lower",
  "tags": [
    "entity:class"
  ],
  "text": "class Lower(Transform)"
}
```
