# Fact 76e735ce

Store id: b7714866-8d22-4651-b515-f9cd6831b7fd

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
- posted_at: `2026-11-09T22:39:45.9414040+00:00`

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
  "id": "b7714866-8d22-4651-b515-f9cd6831b7fd",
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
    "posted_at": "2026-11-09T22:39:45.9414040+00:00"
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
  "subject_id": "7155640f-70cf-4f0f-8f9b-106ffc575068",
  "subject_name": "django/db/models/functions/comparison::Greatest",
  "tags": [
    "entity:class"
  ],
  "text": "class Greatest(Func)"
}
```
