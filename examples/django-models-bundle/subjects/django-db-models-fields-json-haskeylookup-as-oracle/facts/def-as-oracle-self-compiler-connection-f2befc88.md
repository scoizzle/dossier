# Fact f2befc88

Store id: 0b30ee6d-17d3-4a23-9fe9-01a83c550449

## Text

```text
def as_oracle(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:43.6465530+00:00`

## Data

```json
{
  "end_line": 252,
  "entity_kind": "method",
  "parent": "HasKeyLookup",
  "start_line": 237,
  "symbol": "HasKeyLookup.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":237,"selector":"L237-L252","symbol":"HasKeyLookup.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 252,
    "entity_kind": "method",
    "parent": "HasKeyLookup",
    "start_line": 237,
    "symbol": "HasKeyLookup.as_oracle"
  },
  "id": "0b30ee6d-17d3-4a23-9fe9-01a83c550449",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6465530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 237,
        "selector": "L237-L252",
        "symbol": "HasKeyLookup.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "fa715e09-e187-4e39-a532-c3b560ff1fc2",
  "subject_name": "django/db/models/fields/json::HasKeyLookup.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
