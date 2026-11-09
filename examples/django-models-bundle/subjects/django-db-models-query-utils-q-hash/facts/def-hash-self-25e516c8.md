# Fact 25e516c8

Store id: b9327428-f300-4011-b089-96748efe8598

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T23:32:05.0972580+00:00`

## Data

```json
{
  "end_line": 234,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 233,
  "symbol": "Q.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":233,"selector":"L233-L234","symbol":"Q.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 234,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 233,
    "symbol": "Q.__hash__"
  },
  "id": "b9327428-f300-4011-b089-96748efe8598",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0972580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 233,
        "selector": "L233-L234",
        "symbol": "Q.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "d7337673-67fc-41eb-9557-63f7d93b1ade",
  "subject_name": "django/db/models/query_utils::Q.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
