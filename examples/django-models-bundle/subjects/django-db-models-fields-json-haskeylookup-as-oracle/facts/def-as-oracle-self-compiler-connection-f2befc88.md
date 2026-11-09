# Fact f2befc88

Store id: 94701e1c-1da3-4cb9-ab76-0cb3a766b5eb

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
- posted_at: `2026-11-09T23:44:50.9687570+00:00`

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
  "id": "94701e1c-1da3-4cb9-ab76-0cb3a766b5eb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9687570+00:00"
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
  "subject_id": "2e7ad02c-3f70-4cd0-966c-5f48a5d9f47b",
  "subject_name": "django/db/models/fields/json::HasKeyLookup.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
