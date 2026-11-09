# Fact 7f08d090

Store id: 7b247734-60b9-4cba-b331-ed6e7606eb83

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
- posted_at: `2026-11-09T23:32:01.7066920+00:00`

## Data

```json
{
  "end_line": 94,
  "entity_kind": "method",
  "parent": "Degrees",
  "start_line": 88,
  "symbol": "Degrees.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":88,"selector":"L88-L94","symbol":"Degrees.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Degrees.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 94,
    "entity_kind": "method",
    "parent": "Degrees",
    "start_line": 88,
    "symbol": "Degrees.as_oracle"
  },
  "id": "7b247734-60b9-4cba-b331-ed6e7606eb83",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7066920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 88,
        "selector": "L88-L94",
        "symbol": "Degrees.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "6dbd1503-7453-4846-9f3f-b0d55592f870",
  "subject_name": "django/db/models/functions/math::Degrees.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
