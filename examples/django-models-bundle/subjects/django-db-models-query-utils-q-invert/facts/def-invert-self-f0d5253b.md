# Fact f0d5253b

Store id: 142ab307-9052-4fa9-ba94-f63b6cc71756

## Text

```text
def __invert__(self)
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
- posted_at: `2026-11-09T22:39:50.0799460+00:00`

## Data

```json
{
  "end_line": 99,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 96,
  "symbol": "Q.__invert__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":96,"selector":"L96-L99","symbol":"Q.__invert__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__invert__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 99,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 96,
    "symbol": "Q.__invert__"
  },
  "id": "142ab307-9052-4fa9-ba94-f63b6cc71756",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.0799460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 96,
        "selector": "L96-L99",
        "symbol": "Q.__invert__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "0b21912f-1fbd-4033-a0c7-32ee24744b08",
  "subject_name": "django/db/models/query_utils::Q.__invert__",
  "tags": [
    "entity:method"
  ],
  "text": "def __invert__(self)"
}
```
