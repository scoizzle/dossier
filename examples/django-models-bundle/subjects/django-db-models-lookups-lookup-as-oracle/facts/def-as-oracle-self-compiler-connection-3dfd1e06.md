# Fact 3dfd1e06

Store id: fdac9109-c88d-4ba4-a6e0-93e0a8dcffea

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
- posted_at: `2026-11-09T22:39:48.0247080+00:00`

## Data

```json
{
  "end_line": 166,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 150,
  "symbol": "Lookup.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":150,"selector":"L150-L166","symbol":"Lookup.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 166,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 150,
    "symbol": "Lookup.as_oracle"
  },
  "id": "fdac9109-c88d-4ba4-a6e0-93e0a8dcffea",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0247080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 150,
        "selector": "L150-L166",
        "symbol": "Lookup.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a5570229-fe2f-4a7d-a41b-87fc6107dabb",
  "subject_name": "django/db/models/lookups::Lookup.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
