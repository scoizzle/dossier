# Fact f33b4874

Store id: 93c77fea-02ce-4d35-b70e-b57e46bddec7

## Text

```text
def get_bound_params(self, start, finish)
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
- posted_at: `2026-11-09T23:32:03.4619800+00:00`

## Data

```json
{
  "end_line": 778,
  "entity_kind": "method",
  "parent": "YearLte",
  "start_line": 777,
  "symbol": "YearLte.get_bound_params"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":777,"selector":"L777-L778","symbol":"YearLte.get_bound_params"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearLte.get_bound_params](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 778,
    "entity_kind": "method",
    "parent": "YearLte",
    "start_line": 777,
    "symbol": "YearLte.get_bound_params"
  },
  "id": "93c77fea-02ce-4d35-b70e-b57e46bddec7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4619800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 777,
        "selector": "L777-L778",
        "symbol": "YearLte.get_bound_params"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "2e00de9c-422b-4414-94bc-a20485907f91",
  "subject_name": "django/db/models/lookups::YearLte.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
