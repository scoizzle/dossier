# Fact 316299f0

Store id: d9764508-cdb9-49cb-bce8-4943756fed8a

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T23:31:56.5566320+00:00`

## Data

```json
{
  "end_line": 1331,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1330,
  "symbol": "CharField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1330,"selector":"L1330-L1331","symbol":"CharField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1331,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1330,
    "symbol": "CharField.get_internal_type"
  },
  "id": "d9764508-cdb9-49cb-bce8-4943756fed8a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5566320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1330,
        "selector": "L1330-L1331",
        "symbol": "CharField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c5637fdb-d24b-43a3-88e5-aa2acd593103",
  "subject_name": "django/db/models/fields/__init__::CharField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
