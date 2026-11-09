# Fact e77f8531

Store id: 036ab71f-6c3a-4b14-93b4-a00deda61d17

## Text

```text
def __repr__(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.7099540+00:00`

## Data

```json
{
  "end_line": 1748,
  "entity_kind": "method",
  "parent": "Case",
  "start_line": 1747,
  "symbol": "Case.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1747,"selector":"L1747-L1748","symbol":"Case.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Case.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1748,
    "entity_kind": "method",
    "parent": "Case",
    "start_line": 1747,
    "symbol": "Case.__repr__"
  },
  "id": "036ab71f-6c3a-4b14-93b4-a00deda61d17",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7099540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1747,
        "selector": "L1747-L1748",
        "symbol": "Case.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "db6c0254-18be-4023-a133-368f18b9c901",
  "subject_name": "django/db/models/expressions::Case.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
