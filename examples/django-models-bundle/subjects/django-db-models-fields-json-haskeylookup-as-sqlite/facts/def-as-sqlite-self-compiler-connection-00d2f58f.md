# Fact 00d2f58f

Store id: 20e50d48-c48a-4862-80c7-1314b4107780

## Text

```text
def as_sqlite(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:57.8957140+00:00`

## Data

```json
{
  "end_line": 265,
  "entity_kind": "method",
  "parent": "HasKeyLookup",
  "start_line": 262,
  "symbol": "HasKeyLookup.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":262,"selector":"L262-L265","symbol":"HasKeyLookup.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 265,
    "entity_kind": "method",
    "parent": "HasKeyLookup",
    "start_line": 262,
    "symbol": "HasKeyLookup.as_sqlite"
  },
  "id": "20e50d48-c48a-4862-80c7-1314b4107780",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8957140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 262,
        "selector": "L262-L265",
        "symbol": "HasKeyLookup.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "7f0d0482-3107-4418-b06d-0d7a9d36a727",
  "subject_name": "django/db/models/fields/json::HasKeyLookup.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection)"
}
```
