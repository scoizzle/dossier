# Fact a5b29079

Store id: 3519910c-668e-4458-a39e-dddf9c6d2acc

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
- posted_at: `2026-11-09T22:39:41.7811280+00:00`

## Data

```json
{
  "end_line": 2187,
  "entity_kind": "method",
  "parent": "WindowFrame",
  "start_line": 2169,
  "symbol": "WindowFrame.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2169,"selector":"L2169-L2187","symbol":"WindowFrame.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrame.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2187,
    "entity_kind": "method",
    "parent": "WindowFrame",
    "start_line": 2169,
    "symbol": "WindowFrame.as_sql"
  },
  "id": "3519910c-668e-4458-a39e-dddf9c6d2acc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7811280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2169,
        "selector": "L2169-L2187",
        "symbol": "WindowFrame.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "1960a8d9-b301-40cc-990c-cce64437402c",
  "subject_name": "django/db/models/expressions::WindowFrame.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
