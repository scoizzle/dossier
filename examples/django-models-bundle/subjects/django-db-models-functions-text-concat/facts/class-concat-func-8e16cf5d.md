# Fact 8e16cf5d

Store id: ca3b8d8f-6478-4b0a-91ae-63ee82ad2344

## Text

```text
class Concat(Func)
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
- posted_at: `2026-11-09T22:39:47.0916590+00:00`

## Data

```json
{
  "end_line": 151,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 125,
  "symbol": "Concat"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":125,"selector":"L125-L151","symbol":"Concat"}`

## Items

```json
[
  {
    "text": "Concatenate text fields together. Backends that result in an entire null expression when any arguments are null will wrap each argument in coalesce functions to ensure a non-null result.",
    "locator": {
      "line": 126
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/text::Concat](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 151,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 125,
    "symbol": "Concat"
  },
  "id": "ca3b8d8f-6478-4b0a-91ae-63ee82ad2344",
  "items": [
    {
      "locator": {
        "line": 126
      },
      "text": "Concatenate text fields together. Backends that result in an entire null expression when any arguments are null will wrap each argument in coalesce functions to ensure a non-null result."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0916590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 125,
        "selector": "L125-L151",
        "symbol": "Concat"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "95158310-4683-4fee-b606-6ab0c124b04b",
  "subject_name": "django/db/models/functions/text::Concat",
  "tags": [
    "entity:class"
  ],
  "text": "class Concat(Func)"
}
```
