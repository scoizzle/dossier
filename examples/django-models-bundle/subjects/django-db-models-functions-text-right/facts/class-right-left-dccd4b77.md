# Fact dccd4b77

Store id: 88c5c105-4799-4495-8b0a-c9bc1d53d3dd

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
- posted_at: `2026-11-09T23:32:02.2624040+00:00`

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
  "id": "88c5c105-4799-4495-8b0a-c9bc1d53d3dd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2624040+00:00"
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
  "subject_id": "792ad56c-1c0e-4909-ad88-1daab60a17c3",
  "subject_name": "django/db/models/functions/text::Right",
  "tags": [
    "entity:class"
  ],
  "text": "class Right(Left)"
}
```
