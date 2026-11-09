# Fact 3a42b9ea

Store id: 9a312136-bc95-4a58-9c34-bb8d818d9667

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
- posted_at: `2026-11-09T23:44:53.7544920+00:00`

## Data

```json
{
  "end_line": 169,
  "entity_kind": "method",
  "parent": "Random",
  "start_line": 166,
  "symbol": "Random.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":166,"selector":"L166-L169","symbol":"Random.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Random.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 169,
    "entity_kind": "method",
    "parent": "Random",
    "start_line": 166,
    "symbol": "Random.as_oracle"
  },
  "id": "9a312136-bc95-4a58-9c34-bb8d818d9667",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7544920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 166,
        "selector": "L166-L169",
        "symbol": "Random.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "2e6637d9-94c3-46fb-9037-54233f94ad3b",
  "subject_name": "django/db/models/functions/math::Random.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
