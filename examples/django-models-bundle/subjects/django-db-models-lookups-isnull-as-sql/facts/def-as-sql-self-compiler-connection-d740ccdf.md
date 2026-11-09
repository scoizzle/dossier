# Fact d740ccdf

Store id: b0473713-c538-4fbb-a33e-78be6a74ce56

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
- posted_at: `2026-11-09T23:44:55.0436010+00:00`

## Data

```json
{
  "end_line": 688,
  "entity_kind": "method",
  "parent": "IsNull",
  "start_line": 670,
  "symbol": "IsNull.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":670,"selector":"L670-L688","symbol":"IsNull.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IsNull.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 688,
    "entity_kind": "method",
    "parent": "IsNull",
    "start_line": 670,
    "symbol": "IsNull.as_sql"
  },
  "id": "b0473713-c538-4fbb-a33e-78be6a74ce56",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0436010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 670,
        "selector": "L670-L688",
        "symbol": "IsNull.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a4871620-df03-46a1-8282-62ea698beafc",
  "subject_name": "django/db/models/lookups::IsNull.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
