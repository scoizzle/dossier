# Fact 9527b25c

Store id: ff200901-ff1f-44ff-babb-27d8ff2360e5

## Text

```text
def batch_process_rhs(self, compiler, connection, rhs=None)
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
- posted_at: `2026-11-09T23:44:54.8524500+00:00`

## Data

```json
{
  "end_line": 76,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 61,
  "symbol": "Lookup.batch_process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":61,"selector":"L61-L76","symbol":"Lookup.batch_process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.batch_process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 76,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 61,
    "symbol": "Lookup.batch_process_rhs"
  },
  "id": "ff200901-ff1f-44ff-babb-27d8ff2360e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.8524500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 61,
        "selector": "L61-L76",
        "symbol": "Lookup.batch_process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "d72c8aac-4212-414e-a09b-e011ce556c06",
  "subject_name": "django/db/models/lookups::Lookup.batch_process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def batch_process_rhs(self, compiler, connection, rhs=None)"
}
```
