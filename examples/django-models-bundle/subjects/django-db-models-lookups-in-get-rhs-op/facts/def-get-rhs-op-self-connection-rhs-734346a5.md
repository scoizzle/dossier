# Fact 734346a5

Store id: c88780d7-8766-49db-af4b-658a8d321615

## Text

```text
def get_rhs_op(self, connection, rhs)
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
- posted_at: `2026-11-09T23:44:55.0057120+00:00`

## Data

```json
{
  "end_line": 549,
  "entity_kind": "method",
  "parent": "In",
  "start_line": 548,
  "symbol": "In.get_rhs_op"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":548,"selector":"L548-L549","symbol":"In.get_rhs_op"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::In.get_rhs_op](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 549,
    "entity_kind": "method",
    "parent": "In",
    "start_line": 548,
    "symbol": "In.get_rhs_op"
  },
  "id": "c88780d7-8766-49db-af4b-658a8d321615",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0057120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 548,
        "selector": "L548-L549",
        "symbol": "In.get_rhs_op"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "5659758c-c217-44f9-ad49-12e8df2099f4",
  "subject_name": "django/db/models/lookups::In.get_rhs_op",
  "tags": [
    "entity:method"
  ],
  "text": "def get_rhs_op(self, connection, rhs)"
}
```
