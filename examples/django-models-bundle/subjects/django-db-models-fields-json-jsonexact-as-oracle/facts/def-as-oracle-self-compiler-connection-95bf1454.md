# Fact 95bf1454

Store id: f91c1efe-3e49-4820-8046-b40e8f943abd

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
- posted_at: `2026-11-09T23:31:57.9301700+00:00`

## Data

```json
{
  "end_line": 350,
  "entity_kind": "method",
  "parent": "JSONExact",
  "start_line": 344,
  "symbol": "JSONExact.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":344,"selector":"L344-L350","symbol":"JSONExact.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONExact.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 350,
    "entity_kind": "method",
    "parent": "JSONExact",
    "start_line": 344,
    "symbol": "JSONExact.as_oracle"
  },
  "id": "f91c1efe-3e49-4820-8046-b40e8f943abd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9301700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 344,
        "selector": "L344-L350",
        "symbol": "JSONExact.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "6f83de70-f565-4196-93ba-aa15500d9030",
  "subject_name": "django/db/models/fields/json::JSONExact.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
