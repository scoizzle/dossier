# Fact ccdf3b62

Store id: e98b8ea3-ed9e-43d2-afa4-e74bb84178d3

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:31:53.5471270+00:00`

## Data

```json
{
  "end_line": 398,
  "entity_kind": "method",
  "parent": "StringAgg",
  "start_line": 383,
  "symbol": "StringAgg.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":383,"selector":"L383-L398","symbol":"StringAgg.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StringAgg.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 398,
    "entity_kind": "method",
    "parent": "StringAgg",
    "start_line": 383,
    "symbol": "StringAgg.as_oracle"
  },
  "id": "e98b8ea3-ed9e-43d2-afa4-e74bb84178d3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5471270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 383,
        "selector": "L383-L398",
        "symbol": "StringAgg.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "fbdd0c26-bd55-43c6-92d8-b9b975dcbb29",
  "subject_name": "django/db/models/aggregates::StringAgg.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
