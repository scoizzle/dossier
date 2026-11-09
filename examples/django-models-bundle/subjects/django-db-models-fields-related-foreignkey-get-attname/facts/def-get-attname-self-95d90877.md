# Fact 95d90877

Store id: b26e451f-9d13-478c-be21-b7ed0e080efa

## Text

```text
def get_attname(self)
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
- posted_at: `2026-11-09T23:31:58.7629270+00:00`

## Data

```json
{
  "end_line": 1259,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1258,
  "symbol": "ForeignKey.get_attname"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1258,"selector":"L1258-L1259","symbol":"ForeignKey.get_attname"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.get_attname](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1259,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1258,
    "symbol": "ForeignKey.get_attname"
  },
  "id": "b26e451f-9d13-478c-be21-b7ed0e080efa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7629270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1258,
        "selector": "L1258-L1259",
        "symbol": "ForeignKey.get_attname"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "d0d09cc7-ed92-4be3-a6c7-b47962960b0f",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_attname",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname(self)"
}
```
