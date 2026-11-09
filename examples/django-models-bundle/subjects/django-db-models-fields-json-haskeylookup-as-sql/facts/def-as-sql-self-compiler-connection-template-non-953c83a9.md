# Fact 953c83a9

Store id: e8e2dd68-3bf3-4d5d-8d66-0bdd12c858b7

## Text

```text
def as_sql(self, compiler, connection, template=None)
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
- posted_at: `2026-11-09T22:39:43.6422750+00:00`

## Data

```json
{
  "end_line": 230,
  "entity_kind": "method",
  "parent": "HasKeyLookup",
  "start_line": 222,
  "symbol": "HasKeyLookup.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":222,"selector":"L222-L230","symbol":"HasKeyLookup.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 230,
    "entity_kind": "method",
    "parent": "HasKeyLookup",
    "start_line": 222,
    "symbol": "HasKeyLookup.as_sql"
  },
  "id": "e8e2dd68-3bf3-4d5d-8d66-0bdd12c858b7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6422750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 222,
        "selector": "L222-L230",
        "symbol": "HasKeyLookup.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "f64e389f-6ed9-42ad-abcd-cd67a21df190",
  "subject_name": "django/db/models/fields/json::HasKeyLookup.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, template=None)"
}
```
