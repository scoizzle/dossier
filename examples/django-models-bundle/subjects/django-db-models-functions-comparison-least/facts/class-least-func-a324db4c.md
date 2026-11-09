# Fact a324db4c

Store id: 8b6cba3a-8cfc-4013-8000-973724f76dbb

## Text

```text
class Least(Func)
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
- posted_at: `2026-11-09T22:39:45.9498870+00:00`

## Data

```json
{
  "end_line": 162,
  "entity_kind": "class",
  "parent": "comparison",
  "start_line": 144,
  "symbol": "Least"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":144,"selector":"L144-L162","symbol":"Least"}`

## Items

```json
[
  {
    "text": "Return the minimum expression.",
    "locator": {
      "line": 145
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Least](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 162,
    "entity_kind": "class",
    "parent": "comparison",
    "start_line": 144,
    "symbol": "Least"
  },
  "id": "8b6cba3a-8cfc-4013-8000-973724f76dbb",
  "items": [
    {
      "locator": {
        "line": 145
      },
      "text": "Return the minimum expression."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.9498870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 144,
        "selector": "L144-L162",
        "symbol": "Least"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "29f98159-637a-44c2-88bb-ad2f5b09fbec",
  "subject_name": "django/db/models/functions/comparison::Least",
  "tags": [
    "entity:class"
  ],
  "text": "class Least(Func)"
}
```
