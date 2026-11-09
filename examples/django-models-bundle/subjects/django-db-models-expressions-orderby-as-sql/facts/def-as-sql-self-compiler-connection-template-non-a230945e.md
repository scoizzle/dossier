# Fact a230945e

Store id: 637fdab2-83ad-4dc8-8c85-68b2ed053098

## Text

```text
def as_sql(self, compiler, connection, template=None, **extra_context)
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
- posted_at: `2026-11-09T23:31:55.9913030+00:00`

## Data

```json
{
  "end_line": 1978,
  "entity_kind": "method",
  "parent": "OrderBy",
  "start_line": 1944,
  "symbol": "OrderBy.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1944,"selector":"L1944-L1978","symbol":"OrderBy.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1978,
    "entity_kind": "method",
    "parent": "OrderBy",
    "start_line": 1944,
    "symbol": "OrderBy.as_sql"
  },
  "id": "637fdab2-83ad-4dc8-8c85-68b2ed053098",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9913030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1944,
        "selector": "L1944-L1978",
        "symbol": "OrderBy.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "47c4cf42-82df-48bd-8865-c08547cfc2a3",
  "subject_name": "django/db/models/expressions::OrderBy.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, template=None, **extra_context)"
}
```
