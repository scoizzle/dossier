# Fact ff4630f3

Store id: 316f57e0-2392-430a-ac26-dbd7e64470e8

## Text

```text
class Length(Transform)
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
- posted_at: `2026-11-09T23:44:54.0943390+00:00`

## Data

```json
{
  "end_line": 189,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 179,
  "symbol": "Length"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":179,"selector":"L179-L189","symbol":"Length"}`

## Items

```json
[
  {
    "text": "Return the number of characters in the expression.",
    "locator": {
      "line": 180
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/text::Length](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 189,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 179,
    "symbol": "Length"
  },
  "id": "316f57e0-2392-430a-ac26-dbd7e64470e8",
  "items": [
    {
      "locator": {
        "line": 180
      },
      "text": "Return the number of characters in the expression."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0943390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 179,
        "selector": "L179-L189",
        "symbol": "Length"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "8a238e2b-35ee-4c03-8dde-e820fe4c613e",
  "subject_name": "django/db/models/functions/text::Length",
  "tags": [
    "entity:class"
  ],
  "text": "class Length(Transform)"
}
```
