# Fact 3a42b9ea

Store id: 637b9abd-5c92-495d-85eb-6b8343e0c79a

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
- posted_at: `2026-11-09T22:39:46.6581340+00:00`

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
  "id": "637b9abd-5c92-495d-85eb-6b8343e0c79a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6581340+00:00"
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
  "subject_id": "aa394ca4-c9b8-4d96-883d-570b27bd3030",
  "subject_name": "django/db/models/functions/math::Random.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
