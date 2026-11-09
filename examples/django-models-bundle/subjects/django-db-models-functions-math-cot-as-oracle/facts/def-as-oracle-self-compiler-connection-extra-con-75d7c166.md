# Fact 75d7c166

Store id: 7bae9361-ed0e-45a6-902d-880764e71a3b

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
- posted_at: `2026-11-09T23:44:53.7183620+00:00`

## Data

```json
{
  "end_line": 81,
  "entity_kind": "method",
  "parent": "Cot",
  "start_line": 78,
  "symbol": "Cot.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":78,"selector":"L78-L81","symbol":"Cot.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Cot.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 81,
    "entity_kind": "method",
    "parent": "Cot",
    "start_line": 78,
    "symbol": "Cot.as_oracle"
  },
  "id": "7bae9361-ed0e-45a6-902d-880764e71a3b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7183620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 78,
        "selector": "L78-L81",
        "symbol": "Cot.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "06b47226-0cdf-41c7-b2da-9fc0e6d3719e",
  "subject_name": "django/db/models/functions/math::Cot.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
