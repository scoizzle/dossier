# Fact 95bf1454

Store id: b6dc8888-b413-49ec-bcaf-c6776e947785

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
- posted_at: `2026-11-09T22:39:43.6808480+00:00`

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
  "id": "b6dc8888-b413-49ec-bcaf-c6776e947785",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6808480+00:00"
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
  "subject_id": "7072f0ba-8cea-41db-92e9-d2d555a34cf7",
  "subject_name": "django/db/models/fields/json::JSONExact.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
