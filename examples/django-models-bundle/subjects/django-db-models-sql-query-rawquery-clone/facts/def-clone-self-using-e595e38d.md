# Fact e595e38d

Store id: 6a2daf2e-f50c-4a79-a603-6b8acc7d8ad5

## Text

```text
def clone(self, using)
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
- posted_at: `2026-11-09T23:44:58.5479290+00:00`

## Data

```json
{
  "end_line": 174,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 173,
  "symbol": "RawQuery.clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":173,"selector":"L173-L174","symbol":"RawQuery.clone"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery.clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 174,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 173,
    "symbol": "RawQuery.clone"
  },
  "id": "6a2daf2e-f50c-4a79-a603-6b8acc7d8ad5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.5479290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 173,
        "selector": "L173-L174",
        "symbol": "RawQuery.clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c2b6ec2c-56a8-4b63-a650-1c6534e8b06b",
  "subject_name": "django/db/models/sql/query::RawQuery.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self, using)"
}
```
