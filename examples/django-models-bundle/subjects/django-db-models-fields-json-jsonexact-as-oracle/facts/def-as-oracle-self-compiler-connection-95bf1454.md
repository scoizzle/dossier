# Fact 95bf1454

Store id: de2835e4-8b92-4047-80a9-7c8321713897

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
- posted_at: `2026-11-09T23:44:50.9977220+00:00`

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
  "id": "de2835e4-8b92-4047-80a9-7c8321713897",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9977220+00:00"
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
  "subject_id": "c9d9ed96-f65c-4d18-ad7c-93cc0191aaf9",
  "subject_name": "django/db/models/fields/json::JSONExact.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
