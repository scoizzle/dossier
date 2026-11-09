# Fact 575d08bd

Store id: 7285bddc-b908-4c1b-8868-16418c768d66

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
- posted_at: `2026-11-09T23:44:54.0990000+00:00`

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
  "id": "7285bddc-b908-4c1b-8868-16418c768d66",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0990000+00:00"
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
  "subject_id": "2a38dbf9-b2ce-4362-9c66-f4f848e0b0ae",
  "subject_name": "django/db/models/functions/text::Lower",
  "tags": [
    "entity:class"
  ],
  "text": "class Lower(Transform)"
}
```
