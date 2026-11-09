# Fact 3dfd1e06

Store id: d72f9ec1-0c9d-4d90-8108-391a4d128b8d

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
- posted_at: `2026-11-09T23:44:54.8891840+00:00`

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
  "id": "d72f9ec1-0c9d-4d90-8108-391a4d128b8d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.8891840+00:00"
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
  "subject_id": "5eabbe88-c67b-44c0-be61-cf06a4acd695",
  "subject_name": "django/db/models/lookups::Lookup.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
