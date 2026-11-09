# Fact a324db4c

Store id: 2d89fca8-3c57-4b1c-92de-a49aaa925a91

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
- posted_at: `2026-11-09T23:32:01.0010260+00:00`

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
  "id": "2d89fca8-3c57-4b1c-92de-a49aaa925a91",
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
    "posted_at": "2026-11-09T23:32:01.0010260+00:00"
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
  "subject_id": "dfe791e7-d5d7-4e64-904c-de79b3de536d",
  "subject_name": "django/db/models/functions/comparison::Least",
  "tags": [
    "entity:class"
  ],
  "text": "class Least(Func)"
}
```
