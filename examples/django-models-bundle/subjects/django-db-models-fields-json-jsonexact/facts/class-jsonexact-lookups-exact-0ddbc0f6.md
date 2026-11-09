# Fact 0ddbc0f6

Store id: cbc64437-b6ad-40f3-a61b-ad805eac76f3

## Text

```text
class JSONExact(lookups.Exact)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.9260920+00:00`

## Data

```json
{
  "end_line": 350,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 315,
  "symbol": "JSONExact"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":315,"selector":"L315-L350","symbol":"JSONExact"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONExact](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 350,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 315,
    "symbol": "JSONExact"
  },
  "id": "cbc64437-b6ad-40f3-a61b-ad805eac76f3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9260920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 315,
        "selector": "L315-L350",
        "symbol": "JSONExact"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "18be0084-a724-4538-a7e2-ecc17d46bd3f",
  "subject_name": "django/db/models/fields/json::JSONExact",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONExact(lookups.Exact)"
}
```
