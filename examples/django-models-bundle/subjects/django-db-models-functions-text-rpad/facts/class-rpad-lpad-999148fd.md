# Fact 999148fd

Store id: 6b353b8d-7da5-4497-b6e7-a7c97b33e24b

## Text

```text
class RPad(LPad)
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
- posted_at: `2026-11-09T22:39:47.1682590+00:00`

## Data

```json
{
  "end_line": 294,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 293,
  "symbol": "RPad"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":293,"selector":"L293-L294","symbol":"RPad"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::RPad](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 294,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 293,
    "symbol": "RPad"
  },
  "id": "6b353b8d-7da5-4497-b6e7-a7c97b33e24b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1682590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 293,
        "selector": "L293-L294",
        "symbol": "RPad"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "f58dfd62-7da1-4770-b612-a7b078904dd4",
  "subject_name": "django/db/models/functions/text::RPad",
  "tags": [
    "entity:class"
  ],
  "text": "class RPad(LPad)"
}
```
