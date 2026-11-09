# Fact cf0c8c72

Store id: faacb179-7e4b-409b-a2aa-fc8839be197f

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:54.9260670+00:00`

## Data

```json
{
  "end_line": 248,
  "entity_kind": "method",
  "parent": "BuiltinLookup",
  "start_line": 243,
  "symbol": "BuiltinLookup.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":243,"selector":"L243-L248","symbol":"BuiltinLookup.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::BuiltinLookup.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 248,
    "entity_kind": "method",
    "parent": "BuiltinLookup",
    "start_line": 243,
    "symbol": "BuiltinLookup.as_sql"
  },
  "id": "faacb179-7e4b-409b-a2aa-fc8839be197f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9260670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 243,
        "selector": "L243-L248",
        "symbol": "BuiltinLookup.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "956d7adc-6498-495d-817e-b934756db130",
  "subject_name": "django/db/models/lookups::BuiltinLookup.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
