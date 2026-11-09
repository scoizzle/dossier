# Fact 76e735ce

Store id: 240477e6-9420-4ed1-ba4d-c96794b06c3e

## Text

```text
class Greatest(Func)
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
- posted_at: `2026-11-09T23:32:00.9927080+00:00`

## Data

```json
{
  "end_line": 141,
  "entity_kind": "class",
  "parent": "comparison",
  "start_line": 123,
  "symbol": "Greatest"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":123,"selector":"L123-L141","symbol":"Greatest"}`

## Items

```json
[
  {
    "text": "Return the maximum expression.",
    "locator": {
      "line": 124
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Greatest](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 141,
    "entity_kind": "class",
    "parent": "comparison",
    "start_line": 123,
    "symbol": "Greatest"
  },
  "id": "240477e6-9420-4ed1-ba4d-c96794b06c3e",
  "items": [
    {
      "locator": {
        "line": 124
      },
      "text": "Return the maximum expression."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.9927080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 123,
        "selector": "L123-L141",
        "symbol": "Greatest"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "634654b4-954d-45f9-ae1c-fef3196387fc",
  "subject_name": "django/db/models/functions/comparison::Greatest",
  "tags": [
    "entity:class"
  ],
  "text": "class Greatest(Func)"
}
```
